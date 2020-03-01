﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TubeStore.DataLayer;
using TubeStore.Models;
using TubeStore.Models.Notification;
using UserNotifications;
using static UserNotifications.SupportClass;

namespace TubeStore.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IGenericRepository<Invoice> invoices;
        private readonly IGenericRepository<Tube> tubes;
        private readonly IGenericRepository<Notification> notifications;
        private readonly UserManager<Customer> userManager;
        private readonly IUserNotification userNotification;

        public InvoiceController(IGenericRepository<Invoice> invoices,
                                 IGenericRepository<Tube> tubes,
                                 IGenericRepository<Notification> notifications,
                                 UserManager<Customer> userManager,
                                 IUserNotification userNotification)
        {
            this.invoices = invoices;
            this.tubes = tubes;
            this.notifications = notifications;
            this.userManager = userManager;
            this.userNotification = userNotification;
        }

        public async Task<IActionResult> Index()
        {

            Customer customer = userManager.Users.First(x => x.UserName == User.Identity.Name);

            IEnumerable<Invoice> customerInvoices = await
                invoices.FindAllAsync(x => x.CustomerId == customer.Id);
 
            return View(customerInvoices);
        }

        public async Task<IActionResult> SetInactive(int id)
        {
            Invoice invoice = invoices.GetIncluding(x => x.InvoiceId == id,
                    x => x.Customer,
                    x => x.ShippingAddress,
                    x => x.InvoicesInfo).First();

            invoice.Status = EnumStatus.Cancelled;
            await invoices.UpdateAsync(invoice);

            Tube tempTube;

            foreach (var item in invoice.InvoicesInfo)
            {
                tempTube = await tubes.GetAsync(item.TubeId);
                tempTube.Quantity += item.Quantity;
                await tubes.UpdateAsync(tempTube);
            }    
            
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            Invoice invoice = invoices.GetIncluding(x => x.InvoiceId == id,
                    x => x.Customer,
                    x => x.ShippingAddress,
                    x => x.Coupon,
                    x => x.InvoicesInfo).First();

            for (int i = 0; i < invoice.InvoicesInfo.Count; i++)
            {
                invoice.InvoicesInfo[i].Tube = await tubes.GetAsync(invoice.InvoicesInfo[i].TubeId);
            }

            userNotification.AddNotificationSweet("Nice", NotificationType.success, "You opened your invoices");


            return View(invoice);
        }

        public async Task<IActionResult> PayInvoce(int id)
        {
            Invoice invoice = await invoices.GetAsync(id);
            invoice.Status = EnumStatus.Paid;
            await invoices.UpdateAsync(invoice);

            Notification notification = new Notification()
            {
                NotificationText = $"The invoice {invoice.InvoiceId.ToString()} is paid"
            };

            await notifications.AddAsync(notification);

            return RedirectToAction("Index");
        }
    }
}
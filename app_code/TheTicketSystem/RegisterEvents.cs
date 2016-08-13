﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Persistence;
using Umbraco.Core.TheTicketSystem.Objects;

namespace Umbraco.Core.TheTicketSystem
{

    public class RegisterEvents : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            var db = applicationContext.DatabaseContext.Database;

            // Create client table if not exists
            if (!db.TableExist("Client"))
            {
                db.CreateTable<Client>(false);
            }

            // Create ticket table if not exists
            if (!db.TableExist("Ticket"))
            {
                db.CreateTable<Ticket>(false);
            }

            // Create ticketText table if not exists
            if (!db.TableExist("TicketText"))
            {
                db.CreateTable<TicketText>(false);
            }

            // Create Requests table if not exists
            if (!db.TableExist("Requests"))
            {
                db.CreateTable<Requests>(false);
            }
        }
    }
}
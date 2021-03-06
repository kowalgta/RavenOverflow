﻿using CuttingEdge.Conditions;
using Raven.Client;

namespace RavenOverflow.Web.Controllers
{
    public abstract class RavenDbController : BaseController
    {
        protected RavenDbController(IDocumentSession documentSession)
        {
            Condition.Requires(documentSession).IsNotNull();

            DocumentSession = documentSession;
        }

        public IDocumentSession DocumentSession { get; private set; }
    }
}
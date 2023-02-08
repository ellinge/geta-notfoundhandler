// Copyright (c) Geta Digital. All rights reserved.
// Licensed under Apache-2.0. See the LICENSE file in the project root for more information

using System;
using System.Collections.Generic;
using Geta.NotFoundHandler.Core;
using Geta.NotFoundHandler.Core.Redirects;

namespace Geta.NotFoundHandler.Data
{
    public interface IRedirectLoader
    {
        CustomRedirect GetByOldUrl(string oldUrl);

        IEnumerable<CustomRedirect> GetAll();

        CustomRedirectsResult GetRedirects(QueryParams query);

        CustomRedirect Get(Guid id);
    }
}

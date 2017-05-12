using Sitecore.Data.Items;
using Sitecore.ItemWebApi.Pipelines.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.ItemWebApi.Pipelines.Request
{
  public class Search : Sitecore.ItemWebApi.Pipelines.Request.Search
  {
    // Methods
    public override void Process(RequestArgs args)
    {
      base.Process(args);
      args.Items = (from x in args.Items
                    where x != null
                    select x).ToArray<Item>();
    }
  }


}
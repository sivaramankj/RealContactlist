using System;
using System.Collections.Specialized;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using ContactList.Models;
using FastMapper;

namespace ContactList.filters
{
    public class JqgridBinder : IModelBinder
    {
        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            NameValueCollection requestQuery = HttpUtility.ParseQueryString(actionContext.Request.RequestUri.Query);
            // JQGridRequest coDto = TypeAdapter.Adapt<NameValueCollection, JQGridRequest>(qu);


            var coDto = new JQGridRequest
            {
                _search = !string.IsNullOrEmpty(requestQuery["_search"]) && bool.Parse(requestQuery["_search"]),
                filters = string.IsNullOrEmpty(requestQuery["filters"]) ? "" : requestQuery["filters"],
                nd = string.IsNullOrEmpty(requestQuery["nd"]) ? 0 : long.Parse(requestQuery["nd"]),
                page = string.IsNullOrEmpty(requestQuery["page"]) ? 0 : int.Parse(requestQuery["page"]),
                rows = string.IsNullOrEmpty(requestQuery["rows"]) ? 0 : int.Parse(requestQuery["rows"]),
                seachString = string.IsNullOrEmpty(requestQuery["searchString"]) ? "" : requestQuery["searchString"],
                searchField = string.IsNullOrEmpty(requestQuery["searchField"]) ? "" : requestQuery["searchField"],
                searchOper = string.IsNullOrEmpty(requestQuery["searchOper"]) ? "" : requestQuery["searchOper"],
                sidx = string.IsNullOrEmpty(requestQuery["sidx"]) ? 0 : int.Parse(requestQuery["sidx"]),
                sord = string.IsNullOrEmpty(requestQuery["sord"]) ? "" : requestQuery["sord"]
            };
            bindingContext.Model = coDto;
            return true;
        }
    }
}
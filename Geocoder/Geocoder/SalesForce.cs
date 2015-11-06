using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Salesforce.Force;
namespace Geocoder
{
    class SalesForce
    {
        public void Index(string searchString)
        {
            var accessToken = "00D61000000daFJ!AQgAQINgYkYKPlij4ZjYzU3Wbc67901dau4ZHO6HtChRL_aF_KVv.nkmiuDh8PvajhnbWPP2TsaGr8rMf8YTAwZItIW334mk";
            var apiVersion = "v32.0";
            var instanceUrl = "https://na34.salesforce.com";

            var client = new ForceClient(instanceUrl, accessToken, apiVersion);
            var accounts = client.QueryAsync<AccountViewModel>("SELECT id, name, BillingStreet, BillingCity, BillingState, BillingPostalCode FROM Account WHERE name LIKE '%" + searchString + "%'");

        }
    }
    public class AccountViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string BillingStreet { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingPostalCode { get; set; }
    }
}

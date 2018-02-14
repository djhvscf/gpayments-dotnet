using gpayments;
using gpayments.Model;
using System.Collections.Generic;

namespace TestFourGeeksPayments
{
    class Program
    {
        static void Main(string[] args)
        {
            FourGeeksPayments api = new FourGeeksPayments();
            
            Me me = api.GetMyDevInfo();
            me.Page = "http://djhvscf.github.io/Blog/";
            Me newMe = api.UpdateMyDevInfo(me);
            IEnumerable<Customer> customers = api.GetCustomers();

            Customer cu = new Customer();
            cu.Name = "Randy3";
            cu.Email = "randy3@f.com";
            cu.Currency = "usd";
            cu.Card = new Card();
            cu.Card.CardNumber = "5555555555554444";
            cu.Card.ExpirationMonth= 12;
            cu.Card.ExpirationYear= 2018;
            cu.Card.CVC = "123";

            api.CreateCustomer(cu);



            //Customer customer = api.GetCustomer("bg57jp0j2NwQ7C6bYfwkFryJp7RQCIBm");

            //customer.Key = "bg57jp0j2NwQ7C6bYfwkFryJp7RQCIBm";
            //customer.Email = "sophyconejo@hotmail.com";
            //customer.Card.CardNumber = "5555555555554444";
            //customer.Card.CVC= "147";
            //Customer updateCustomer = api.UpdateCustomer(customer);

            //api.DeleteCustomer("bg57jp0j2NwQ7C6bYfwkFryJp7RQCIBm");

            //Charge charge = new Charge();
            //charge.Amount = 25;
            //charge.Currency = "usd";
            //charge.CustomerKey = "6d9EkG5OImElyHwnaOX8SUnmIpnOWAll";
            //charge.Description = "TEST DESCRIPTION";
            //charge.EntityDescription = "Entity";
            //api.CreateCharge(charge);

            //SimpleCharge charge = new SimpleCharge();
            //charge.Amount = 25;
            //charge.Currency = "usd";
            //charge.Description = "TEST DESCRIPTION";
            //charge.EntityDescription = "Entity";
            //charge.CreditCardNumber = "4242424242424242";
            //charge.CVC = "123";
            //charge.ExpirationMonth = 11;
            //charge.ExpirationYear = 2020;
            //api.CreateSimpleCharge(charge);

            //IEnumerable<Log> logs = api.GetLogs();

            //Log log = api.GetLog("1BvEZ6CqnAMAMqhv88CM9gZW");

            /*  -F 'name=Monthly Plan' \
            -F 'amount=300000' \
            -F 'currency=crc' \
            -F 'trial_period_days=0' \
            -F 'interval=month' \
            -F 'interval_count=1' \
            -F 'credit_card_description=Descripción'*/

            //Plan plan = new Plan();
            //plan.Amount = 25;
            //plan.CreditCardDescription = "Descripción";
            //plan.Currency = "crc";
            //plan.Interval = "month";
            //plan.IntervalCount = 1;
            //plan.Name = "Monthly Plan 4";
            //plan.TrialPeriodDays = 15;

            //api.CreatePlan(plan);
            //IEnumerable<ListPlan> planes = api.GetPlans();
            //ListPlan plan = api.GetPlan("ba5a4545-f172-4370-bbc9-14937c62172c");

            //api.DeletePlan("641f12c0-807a-41ed-ab66-df5dee477c7f");

            //api.CreateSubscription("6d9EkG5OImElyHwnaOX8SUnmIpnOWAll", "c0a65eaf-4ac7-4bc8-a516-d8fa3ebeeb23");
            //IEnumerable<Subscription> subscriptions = api.GetSubscriptions();
            //Subscription subscription = api.GetSubscription("CJuruHd7CPm0is");

            //api.DeleteSubscription("CJuruHd7CPm0is");

            //Refund refund = api.CreateRefund(1, "1BvEsYCqnAMAMqhvmWtmgORr", "requested_by_customer");
            //IEnumerable<Refund> refunds = api.GetRefunds();

            //Refund refund = api.GetRefund("1BvHM8CqnAMAMqhv6RHcgZO0");
        }
    }
}

﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Yandex.Checkout.V3.Demo.Pages
{
    public class FinishAsyncModel : PageModel
    {
        public int Id { get; private set; }
        public string Payment { get; private set; }

        public async Task OnGetAsync(int id)
        {
            var data = PaymentStorage.Payments[id];
            Id = id;

            Payment = Client.SerializeObject(await data.Client.QueryPaymentAsync(data.Payment.Id));
        }
    }
}

using CoreAPIBank.Models.ContextClasses;
using CoreAPIBank.Models.Entities;
using CoreAPIBank.RequestModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace CoreAPIBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        MyContext _db;

        public TransactionController(MyContext db)
        {
            _db = db;
        }

        [HttpPost]

        public async Task<IActionResult> StartTransaction(PaymentRequestModel item)
        {
            if (_db.CardInfoes.Any(x=> x.CardNumber == item.CardNumber && x.CCV == item.CCV && x.CardUserName == item.CardUserName))
            {
                UserCardInfo uCInfo = await _db.CardInfoes.SingleOrDefaultAsync(x => x.CardNumber == item.CardNumber && x.CCV == item.CCV && x.CardUserName == item.CardUserName);

                if (item.ExpiryYear < DateTime.Now.Year || (item.ExpiryYear == DateTime.Now.Year && item.ExpiryMonth < DateTime.Now.Month))
                {
                    return StatusCode(400, "Card has expired"); // Kartın süresi dolmuş
                }


                if (uCInfo.Balance >= item.ShoppingPrice)
                {
                    uCInfo.Balance -= item.ShoppingPrice; //Fiyat, kartın balance'ndan düşüyor.

                    await _db.SaveChangesAsync();

                    return Ok("Payment successfully received.");//Ödeme başarıyla alındı
                }

                else
                {
                    return StatusCode(400, "Card balance is insufficient"); //Kart bakiyesi yetersiz
                }

            }

            return StatusCode(400, "Card information was incorrectly entered"); //Kart bilgileri yanlış girildi
        }             
    }
}

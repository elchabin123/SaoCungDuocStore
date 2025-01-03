using SaoCungDuocStore.Models;

namespace SaoCungDuocStore.Servicess
{
    public interface IVnpayService
    {
        string CreatePaymentUrl(HttpContext context, VnPaymentRequestModel model);
        VnPaymentResponseModel PaymentExcute(IQueryCollection collections);
    }
}
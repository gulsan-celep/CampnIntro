//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;
//using InterfaceAbstractDemo.Abstract;
//using InterfaceAbstractDemo.Entities;
//using MernisServiceReference;

//namespace InterfaceAbstractDemo.Adapters
//{
//    public class MernisServiceAdapter : IPersonCheckService
//    {
//        public bool CheckIfRealPerson(Customer customer)
//        {
//            return TaskAsync(customer).Result;
//        }
//        public static async Task<bool> TaskAsync(Customer customer)
//        {
//            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
//            var status = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year));

//            return status.Body.TCKimlikNoDogrulaResult;
//        }
//    }
//}

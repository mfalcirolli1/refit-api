using Refit;
using RefitApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefitApi.Interface
{
    internal interface IAPIService
    {
        [Get("/ws/{cep}/json")]
        Task<ViaCepModel> GetAddressInformation(string cep);
    }
}

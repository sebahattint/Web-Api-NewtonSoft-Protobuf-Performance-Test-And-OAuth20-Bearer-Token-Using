using Newtonsoft.Json;
using SampleProject.WebApi.CustomAttributes;
using SampleProject.WebApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleProject.WebApi.Controllers
{
    /// <summary>
    /// Author      : Sebahattin Tonbul
    /// Description : You can compare ProtoBuf and NewtonSoft.
    /// Sample Test for 1000 record.
    /// ProtoBuf   : 21ms, 54 kb.
    /// NewtonSoft : 74ms, 170 kb. 
    /// </summary>
    public class ProductController : ApiController
    {
        [Route("api/test-serializer/{serializeType}")]
        [HttpGet,CustomAuthorize]
        public object TestSerializer([FromUri]string serializeType)
        {
            List<ProductViewModel> productList = FillDummyData(); //1000 kayıt 

            int type = serializeType == "protobuf" ? 1 : serializeType == "newtonsoft" ? 2 : 0;

            switch (type)
            {
                case (int)SerializeTypes.ProtoBuf:
                    return ProtoBufSerializer.ProtoSerialize(productList);
                case (int)SerializeTypes.NewtonSoft:
                    return JsonConvert.SerializeObject(productList);
                default:
                    return "Invalid serialize type.";
            }
        }

        private List<ProductViewModel> FillDummyData()
        {
            List<ProductViewModel> productList = new List<ProductViewModel>();

            for (int i = 0; i < 1000; i++)
            {
                productList.Add(new ProductViewModel()
                {
                    ProductId = 1,
                    ProductName = "Test",
                    Description = "This is a test",
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false
                });
            }

            return productList;
        }
    }

    //You can define Project.Common/Enumerations
    public enum SerializeTypes
    {
        ProtoBuf = 1,
        NewtonSoft = 2
    }
}

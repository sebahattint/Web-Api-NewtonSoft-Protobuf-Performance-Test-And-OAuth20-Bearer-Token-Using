using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleProject.WebApi.Models
{
    [ProtoContract(SkipConstructor = true)]
    public class ProductViewModel
    {
        [ProtoMember(1)]
        public int ProductId { get; set; }
        [ProtoMember(2)]
        public string ProductName { get; set; }
        [ProtoMember(3)]
        public string Description { get; set; }
        [ProtoMember(4)]
        public DateTime CreatedDate { get; set; }
        [ProtoMember(5)]
        public bool IsActive { get; set; }
        [ProtoMember(6)]
        public bool IsDeleted { get; set; }
    }
}
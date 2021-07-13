using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Models.Entities
{
    [DataContract]
    public class BaseEntity
    {
        [DataMember]
        public int Id { get; protected set; }
    }
}

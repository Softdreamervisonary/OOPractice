using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunCashier.Service
{
    public class MemberService : IMemberService
    {
        Guid MTID;

        public MemberService(Guid _MTID)
        {
            this.MTID = _MTID;
        }

        public bool GetMember()
        {
            throw new NotImplementedException();
        }
    }
}

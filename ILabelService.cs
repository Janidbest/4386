using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Host.Services
{
    public interface ILabelService
    {
        string Username { get;  }
        string EmailAddress { get;  }
        string Password { get;  }
    }
}

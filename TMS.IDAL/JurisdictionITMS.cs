using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;
using TMS.IRepository;

namespace TMS.IRepository
{
    public interface JurisdictionITMS : TMSIRepository<MenuModel>
    {

        List<MenuModel> Use(int id);

        List<MenuModel> Use2(int id);

    }
}

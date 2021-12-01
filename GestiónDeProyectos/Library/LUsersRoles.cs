using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestiónDeProyectos.Library
{
    public class LUsersRoles
    {
        public List<SelectListItem> getRoles(Microsoft.AspNetCore.Identity.RoleManager<IdentityRole> roleManager)
        {
            List<SelectListItem> _selectList = new List<SelectListItem>();
            var roles = roleManager.Roles.ToList();
            roles.ForEach(item => {
                _selectList.Add(new SelectListItem
                {
                    Value = item.Id,
                    Text = item.Name
                }) ;
            });
            return _selectList;
        }
    }
}

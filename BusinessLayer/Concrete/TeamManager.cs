using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            this.teamDal = teamDal;
        }

        public void Delete(Team t)
        {
            teamDal.Delete(t);
        }

        public Team GetById(int id)
        {
            return teamDal.GetById(id);
        }

        public List<Team> GetListAll()
        {
            return teamDal.GetListAll();
        }

        public void Insert(Team t)
        {
            teamDal.Insert(t);
        }

        public void Update(Team t)
        {
            teamDal.Update(t);
        }
    }
}

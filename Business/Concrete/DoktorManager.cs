using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DoktorManager : IDoktorService
    {
        private IDoktorDal _doktorDal;

        private IHastaDal _hastaDal;

        public DoktorManager(IDoktorDal doktorDal)
        {
            _doktorDal = doktorDal;
        }

        public IResult Add(Doktor doktor)
        {
            //Business codes

            //hasta kayıt sadece 08-17 saatleri arasında yapılabilir
            if (DateTime.Now.Hour < 8 || DateTime.Now.Hour > 17)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }

            _doktorDal.Add(doktor);
            return new SuccessResult();
        }

        public IResult Delete(Doktor doktor)
        {

            _doktorDal.Delete(doktor);
            return new SuccessResult();
        }

        public IDataResult<List<Doktor>> GetAll()
        {

            return new SuccessDataResult<List<Doktor>>(_doktorDal.GetAll());
        }

        public IDataResult<Doktor> GetById(int id)
        {
            return new SuccessDataResult<Doktor>(_doktorDal.Get(d => d.doktorID == id));

        }

        public IResult Update(Doktor doktor)
        {
            _doktorDal.Update(doktor);
            return new SuccessResult();
        }
    }
}

using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //istediğimiz kadar parametre gönderebiliriz
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;       //parametre ile gönderilen iş kurallarından başarısız olanı business a haberdar ediyoruz
                }
            }
            return null;
        }
    }
}

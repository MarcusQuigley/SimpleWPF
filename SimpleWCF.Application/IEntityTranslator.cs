using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWCF.Application
{
    public interface IEntityTranslator<M, D>
    {
        M CreateModel(D dto);
        M UpdateModel(M Model, D dto);
        D UpdateData(M Model, D dto);
    }
}

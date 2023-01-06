using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //for return data operations
    public interface IDataResult<T>: IResult
    {
        T Data { get; }
    }
}

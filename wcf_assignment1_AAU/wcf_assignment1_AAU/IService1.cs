using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1_AAU
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //Methods

        [OperationContract]
        string Check_Prime(int n);

        [OperationContract]
        int Sum_Digit(int num);

        [OperationContract]
        string Reverse_String(string stringToReverse);

        [OperationContract]
        string Print_Tag(string tag, string data);

        [OperationContract]
        int[] sorting(string sortType, int[]data);

    }

}

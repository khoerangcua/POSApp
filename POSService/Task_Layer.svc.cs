using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace POSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Task_Layer" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Task_Layer.svc or Task_Layer.svc.cs at the Solution Explorer and start debugging.
    public class Task_Layer : ITask_Layer
    {
        public bool AddHoaDonItem(int idhoadon, int idsanpham, int soluong)
        {
            throw new NotImplementedException();
        }

        public void DoWork()
        {
        }

        public void GuiMail(int idhoadon)
        {
            throw new NotImplementedException();
        }

        public bool ThanhToanBangThe(int idhoadon)
        {
            throw new NotImplementedException();
        }

        public bool ThanhToanTienMat(int idhoadon)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTongTienHoaDon(int idhoadon)
        {
            throw new NotImplementedException();
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test_QLBTS.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMy_QLBTS")]
    public interface IMy_QLBTS {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/DoWork", ReplyAction="http://tempuri.org/IMy_QLBTS/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/DoWork", ReplyAction="http://tempuri.org/IMy_QLBTS/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xem_ThanhVien", ReplyAction="http://tempuri.org/IMy_QLBTS/Xem_ThanhVienResponse")]
        System.Data.DataTable Xem_ThanhVien();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xem_ThanhVien", ReplyAction="http://tempuri.org/IMy_QLBTS/Xem_ThanhVienResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> Xem_ThanhVienAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Them_ThanhVien", ReplyAction="http://tempuri.org/IMy_QLBTS/Them_ThanhVienResponse")]
        bool Them_ThanhVien(string matv, int stt, string hoten, string loaithanhvien, string sodt, string email, string diachi, int diemtichluy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Them_ThanhVien", ReplyAction="http://tempuri.org/IMy_QLBTS/Them_ThanhVienResponse")]
        System.Threading.Tasks.Task<bool> Them_ThanhVienAsync(string matv, int stt, string hoten, string loaithanhvien, string sodt, string email, string diachi, int diemtichluy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xoa_ThanhVien", ReplyAction="http://tempuri.org/IMy_QLBTS/Xoa_ThanhVienResponse")]
        bool Xoa_ThanhVien(string matv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xoa_ThanhVien", ReplyAction="http://tempuri.org/IMy_QLBTS/Xoa_ThanhVienResponse")]
        System.Threading.Tasks.Task<bool> Xoa_ThanhVienAsync(string matv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Sua_ThanhVien", ReplyAction="http://tempuri.org/IMy_QLBTS/Sua_ThanhVienResponse")]
        bool Sua_ThanhVien(string matv, int stt, string hoten, string loaithanhvien, string sodt, string email, string diachi, int diemtichluy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Sua_ThanhVien", ReplyAction="http://tempuri.org/IMy_QLBTS/Sua_ThanhVienResponse")]
        System.Threading.Tasks.Task<bool> Sua_ThanhVienAsync(string matv, int stt, string hoten, string loaithanhvien, string sodt, string email, string diachi, int diemtichluy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xem_DoUong", ReplyAction="http://tempuri.org/IMy_QLBTS/Xem_DoUongResponse")]
        System.Data.DataTable Xem_DoUong();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xem_DoUong", ReplyAction="http://tempuri.org/IMy_QLBTS/Xem_DoUongResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> Xem_DoUongAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Them_DoUong", ReplyAction="http://tempuri.org/IMy_QLBTS/Them_DoUongResponse")]
        bool Them_DoUong(string tendu, string size, double dongia, int maloai, string image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Them_DoUong", ReplyAction="http://tempuri.org/IMy_QLBTS/Them_DoUongResponse")]
        System.Threading.Tasks.Task<bool> Them_DoUongAsync(string tendu, string size, double dongia, int maloai, string image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xoa_DoUong", ReplyAction="http://tempuri.org/IMy_QLBTS/Xoa_DoUongResponse")]
        bool Xoa_DoUong(int madu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xoa_DoUong", ReplyAction="http://tempuri.org/IMy_QLBTS/Xoa_DoUongResponse")]
        System.Threading.Tasks.Task<bool> Xoa_DoUongAsync(int madu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Sua_DoUong", ReplyAction="http://tempuri.org/IMy_QLBTS/Sua_DoUongResponse")]
        bool Sua_DoUong(int madu, string tenloai, string tendu, string size, double dongia, int maloai, string image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Sua_DoUong", ReplyAction="http://tempuri.org/IMy_QLBTS/Sua_DoUongResponse")]
        System.Threading.Tasks.Task<bool> Sua_DoUongAsync(int madu, string tenloai, string tendu, string size, double dongia, int maloai, string image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xem_Topping", ReplyAction="http://tempuri.org/IMy_QLBTS/Xem_ToppingResponse")]
        System.Data.DataTable Xem_Topping();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xem_Topping", ReplyAction="http://tempuri.org/IMy_QLBTS/Xem_ToppingResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> Xem_ToppingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Them_Topping", ReplyAction="http://tempuri.org/IMy_QLBTS/Them_ToppingResponse")]
        bool Them_Topping(string matp, string tentp, double gia, string image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Them_Topping", ReplyAction="http://tempuri.org/IMy_QLBTS/Them_ToppingResponse")]
        System.Threading.Tasks.Task<bool> Them_ToppingAsync(string matp, string tentp, double gia, string image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xoa_Topping", ReplyAction="http://tempuri.org/IMy_QLBTS/Xoa_ToppingResponse")]
        bool Xoa_Topping(string matp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xoa_Topping", ReplyAction="http://tempuri.org/IMy_QLBTS/Xoa_ToppingResponse")]
        System.Threading.Tasks.Task<bool> Xoa_ToppingAsync(string matp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Sua_Topping", ReplyAction="http://tempuri.org/IMy_QLBTS/Sua_ToppingResponse")]
        bool Sua_Topping(string matp, string tentp, double gia, string image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Sua_Topping", ReplyAction="http://tempuri.org/IMy_QLBTS/Sua_ToppingResponse")]
        System.Threading.Tasks.Task<bool> Sua_ToppingAsync(string matp, string tentp, double gia, string image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/GetID", ReplyAction="http://tempuri.org/IMy_QLBTS/GetIDResponse")]
        int GetID(string taikhoan, string matkhau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/GetID", ReplyAction="http://tempuri.org/IMy_QLBTS/GetIDResponse")]
        System.Threading.Tasks.Task<int> GetIDAsync(string taikhoan, string matkhau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/GetName", ReplyAction="http://tempuri.org/IMy_QLBTS/GetNameResponse")]
        string GetName(string taikhoan, string matkhau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/GetName", ReplyAction="http://tempuri.org/IMy_QLBTS/GetNameResponse")]
        System.Threading.Tasks.Task<string> GetNameAsync(string taikhoan, string matkhau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/GetPass", ReplyAction="http://tempuri.org/IMy_QLBTS/GetPassResponse")]
        string GetPass(string taikhoan, string matkhau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/GetPass", ReplyAction="http://tempuri.org/IMy_QLBTS/GetPassResponse")]
        System.Threading.Tasks.Task<string> GetPassAsync(string taikhoan, string matkhau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Quen_Pass", ReplyAction="http://tempuri.org/IMy_QLBTS/Quen_PassResponse")]
        bool Quen_Pass(string tentaikhoan, string sodt, string newpass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Quen_Pass", ReplyAction="http://tempuri.org/IMy_QLBTS/Quen_PassResponse")]
        System.Threading.Tasks.Task<bool> Quen_PassAsync(string tentaikhoan, string sodt, string newpass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Change_Pass", ReplyAction="http://tempuri.org/IMy_QLBTS/Change_PassResponse")]
        bool Change_Pass(int ID, string newpass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Change_Pass", ReplyAction="http://tempuri.org/IMy_QLBTS/Change_PassResponse")]
        System.Threading.Tasks.Task<bool> Change_PassAsync(int ID, string newpass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xem_TuyTron", ReplyAction="http://tempuri.org/IMy_QLBTS/Xem_TuyTronResponse")]
        System.Data.DataTable Xem_TuyTron(string query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMy_QLBTS/Xem_TuyTron", ReplyAction="http://tempuri.org/IMy_QLBTS/Xem_TuyTronResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> Xem_TuyTronAsync(string query);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMy_QLBTSChannel : Test_QLBTS.ServiceReference1.IMy_QLBTS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class My_QLBTSClient : System.ServiceModel.ClientBase<Test_QLBTS.ServiceReference1.IMy_QLBTS>, Test_QLBTS.ServiceReference1.IMy_QLBTS {
        
        public My_QLBTSClient() {
        }
        
        public My_QLBTSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public My_QLBTSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public My_QLBTSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public My_QLBTSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public System.Data.DataTable Xem_ThanhVien() {
            return base.Channel.Xem_ThanhVien();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> Xem_ThanhVienAsync() {
            return base.Channel.Xem_ThanhVienAsync();
        }
        
        public bool Them_ThanhVien(string matv, int stt, string hoten, string loaithanhvien, string sodt, string email, string diachi, int diemtichluy) {
            return base.Channel.Them_ThanhVien(matv, stt, hoten, loaithanhvien, sodt, email, diachi, diemtichluy);
        }
        
        public System.Threading.Tasks.Task<bool> Them_ThanhVienAsync(string matv, int stt, string hoten, string loaithanhvien, string sodt, string email, string diachi, int diemtichluy) {
            return base.Channel.Them_ThanhVienAsync(matv, stt, hoten, loaithanhvien, sodt, email, diachi, diemtichluy);
        }
        
        public bool Xoa_ThanhVien(string matv) {
            return base.Channel.Xoa_ThanhVien(matv);
        }
        
        public System.Threading.Tasks.Task<bool> Xoa_ThanhVienAsync(string matv) {
            return base.Channel.Xoa_ThanhVienAsync(matv);
        }
        
        public bool Sua_ThanhVien(string matv, int stt, string hoten, string loaithanhvien, string sodt, string email, string diachi, int diemtichluy) {
            return base.Channel.Sua_ThanhVien(matv, stt, hoten, loaithanhvien, sodt, email, diachi, diemtichluy);
        }
        
        public System.Threading.Tasks.Task<bool> Sua_ThanhVienAsync(string matv, int stt, string hoten, string loaithanhvien, string sodt, string email, string diachi, int diemtichluy) {
            return base.Channel.Sua_ThanhVienAsync(matv, stt, hoten, loaithanhvien, sodt, email, diachi, diemtichluy);
        }
        
        public System.Data.DataTable Xem_DoUong() {
            return base.Channel.Xem_DoUong();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> Xem_DoUongAsync() {
            return base.Channel.Xem_DoUongAsync();
        }
        
        public bool Them_DoUong(string tendu, string size, double dongia, int maloai, string image) {
            return base.Channel.Them_DoUong(tendu, size, dongia, maloai, image);
        }
        
        public System.Threading.Tasks.Task<bool> Them_DoUongAsync(string tendu, string size, double dongia, int maloai, string image) {
            return base.Channel.Them_DoUongAsync(tendu, size, dongia, maloai, image);
        }
        
        public bool Xoa_DoUong(int madu) {
            return base.Channel.Xoa_DoUong(madu);
        }
        
        public System.Threading.Tasks.Task<bool> Xoa_DoUongAsync(int madu) {
            return base.Channel.Xoa_DoUongAsync(madu);
        }
        
        public bool Sua_DoUong(int madu, string tenloai, string tendu, string size, double dongia, int maloai, string image) {
            return base.Channel.Sua_DoUong(madu, tenloai, tendu, size, dongia, maloai, image);
        }
        
        public System.Threading.Tasks.Task<bool> Sua_DoUongAsync(int madu, string tenloai, string tendu, string size, double dongia, int maloai, string image) {
            return base.Channel.Sua_DoUongAsync(madu, tenloai, tendu, size, dongia, maloai, image);
        }
        
        public System.Data.DataTable Xem_Topping() {
            return base.Channel.Xem_Topping();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> Xem_ToppingAsync() {
            return base.Channel.Xem_ToppingAsync();
        }
        
        public bool Them_Topping(string matp, string tentp, double gia, string image) {
            return base.Channel.Them_Topping(matp, tentp, gia, image);
        }
        
        public System.Threading.Tasks.Task<bool> Them_ToppingAsync(string matp, string tentp, double gia, string image) {
            return base.Channel.Them_ToppingAsync(matp, tentp, gia, image);
        }
        
        public bool Xoa_Topping(string matp) {
            return base.Channel.Xoa_Topping(matp);
        }
        
        public System.Threading.Tasks.Task<bool> Xoa_ToppingAsync(string matp) {
            return base.Channel.Xoa_ToppingAsync(matp);
        }
        
        public bool Sua_Topping(string matp, string tentp, double gia, string image) {
            return base.Channel.Sua_Topping(matp, tentp, gia, image);
        }
        
        public System.Threading.Tasks.Task<bool> Sua_ToppingAsync(string matp, string tentp, double gia, string image) {
            return base.Channel.Sua_ToppingAsync(matp, tentp, gia, image);
        }
        
        public int GetID(string taikhoan, string matkhau) {
            return base.Channel.GetID(taikhoan, matkhau);
        }
        
        public System.Threading.Tasks.Task<int> GetIDAsync(string taikhoan, string matkhau) {
            return base.Channel.GetIDAsync(taikhoan, matkhau);
        }
        
        public string GetName(string taikhoan, string matkhau) {
            return base.Channel.GetName(taikhoan, matkhau);
        }
        
        public System.Threading.Tasks.Task<string> GetNameAsync(string taikhoan, string matkhau) {
            return base.Channel.GetNameAsync(taikhoan, matkhau);
        }
        
        public string GetPass(string taikhoan, string matkhau) {
            return base.Channel.GetPass(taikhoan, matkhau);
        }
        
        public System.Threading.Tasks.Task<string> GetPassAsync(string taikhoan, string matkhau) {
            return base.Channel.GetPassAsync(taikhoan, matkhau);
        }
        
        public bool Quen_Pass(string tentaikhoan, string sodt, string newpass) {
            return base.Channel.Quen_Pass(tentaikhoan, sodt, newpass);
        }
        
        public System.Threading.Tasks.Task<bool> Quen_PassAsync(string tentaikhoan, string sodt, string newpass) {
            return base.Channel.Quen_PassAsync(tentaikhoan, sodt, newpass);
        }
        
        public bool Change_Pass(int ID, string newpass) {
            return base.Channel.Change_Pass(ID, newpass);
        }
        
        public System.Threading.Tasks.Task<bool> Change_PassAsync(int ID, string newpass) {
            return base.Channel.Change_PassAsync(ID, newpass);
        }
        
        public System.Data.DataTable Xem_TuyTron(string query) {
            return base.Channel.Xem_TuyTron(query);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> Xem_TuyTronAsync(string query) {
            return base.Channel.Xem_TuyTronAsync(query);
        }
    }
}

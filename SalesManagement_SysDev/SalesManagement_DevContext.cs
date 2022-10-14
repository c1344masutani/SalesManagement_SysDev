using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// EntityFrameworkを利用する
using System.Data.Entity;


namespace SalesManagement_SysDev
{
    class SalesManagement_DevContext : DbContext
    {
        public DbSet<M_Client> M_Clients { get; set; }
        public DbSet<M_Employee> M_Employees { get; set; }
        public DbSet<M_MajorCassification> M_MajorCassifications { get; set; }
        public DbSet<M_Maker> M_Makers { get; set; }
        public DbSet<M_Position> M_Positions { get; set; }
        public DbSet<M_Product> M_Products { get; set; }
        public DbSet<M_SalesOffice> M_SalesOffices { get; set; }
        public DbSet<M_SmallClassification> M_SmallClassifications { get; set; }
        public DbSet<T_Arrival> T_Arrivals { get; set; }
        public DbSet<T_ArrivalDetail> T_ArrivalDetails { get; set; }
        public DbSet<T_Chumon> T_Chumons { get; set; }
        public DbSet<T_ChumonDetail> T_ChumonDetails { get; set; }
        public DbSet<T_Hattyu> T_Hattyus { get; set; }
        public DbSet<T_HattyuDetail> T_HattyuDetails { get; set; }
        public DbSet<T_LoginHistory> T_LoginHistorys { get; set; }
        public DbSet<T_OperationHistory> T_OperationHistorys { get; set; }
        public DbSet<T_Order> T_Orders { get; set; }
        public DbSet<T_OrderDetail> T_OrderDetails { get; set; }
        public DbSet<T_Sale> T_Sale { get; set; }
        public DbSet<T_SaleDetail> T_SaleDetails { get; set; }
        public DbSet<T_Shipment> T_Shipments { get; set; }
        public DbSet<T_ShipmentDetail> T_ShipmentDetails { get; set; }
        public DbSet<T_Stock> T_Stocks { get; set; }
        public DbSet<T_Syukko> T_Syukkos { get; set; }
        public DbSet<T_SyukkoDetail> T_SyukkoDetails { get; set; }
        public DbSet<T_Warehousing> T_Warehousings { get; set; }
        public DbSet<T_WarehousingDetail> T_WarehousingDetails { get; set; }
    }
}

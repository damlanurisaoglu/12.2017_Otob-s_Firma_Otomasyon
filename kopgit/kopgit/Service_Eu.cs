using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace anaekran
{
    public class Service_Eu
    {
        

        public SqlDataReader  Login_insert_DataReader(string adsoyad, int tc, string kullaniciadi,string sifre, int telno,string eposta, string sehir)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC  sp_Login_insert '{0}',{1},'{2}','{3}',{4},'{5}','{6}'", adsoyad, tc,kullaniciadi, sifre, telno, eposta, sehir));
            return dr; 
        }
        public SqlDataReader kayitlar_insert(Int64 TC, string adsoyad, int koltukno, string tarih, string saat, int seferno, string kalkis, string varis, int musteriID)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC  sp_kayitlar_insert {0},'{1}',{2},'{3}','{4}',{5},'{6}','{7}',{8}", TC, adsoyad,koltukno,tarih,saat,seferno,kalkis,varis,musteriID));
            return dr; 
        }
        public SqlDataReader koltuk_update(int eskikoltukno, int yenikoltukno, int seferno)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC  sp_koltuk_update {0},{1},{2}", eskikoltukno,yenikoltukno,seferno));
            return dr;
        }
        public SqlDataReader sefer_insert(string kalkis, string varis, string tarih, string saat)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC  sp_sefer_insert '{0}','{1}','{2}','{3}'", kalkis,varis,tarih,saat));
            return dr;
        }

        public SqlDataReader SP_BACKUP()
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC  sp_BACKUP "));
            return dr;
        }
        public SqlDataReader SP_RESTORE()
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC  sp_RESTORE "));
            return dr;
        }
        public SqlDataReader kayitlar_delete( int seferno,  int koltukno)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC  sp_kayıt_sil {0},{1}", seferno,koltukno));
            return dr;
        }
        
        public SqlDataReader sefer_delete(int seferno)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC  sp_sefer_sil {0}", seferno));
            return dr;
        }
        public SqlDataReader silinmissefer_delete(int seferno)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC  sp_silinmissefer_sil {0}", seferno));
            return dr;
        }
        public SqlDataReader kayırlar_rezerve_insert(Int64 TC, string adsoyad, int koltukno, string tarih, string saat, int seferno, string kalkis, string varis, int musteriID, string durum)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC  sp_kayitlar_rezerveinsert {0},'{1}',{2},'{3}','{4}',{5},'{6}','{7}',{8},'{9}'", TC, adsoyad, koltukno, tarih, saat, seferno, kalkis, varis, musteriID,durum));
            return dr;
        }


        public DataTable Login_DataTable(string KullaniciAdi,string Sifre )
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC sp_Login '{0}','{1}'", KullaniciAdi,Sifre));
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt; 
        }
       
        public DataTable adminsefer_select()
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(" select * from Seferler where Tarih>convert(varchar,GETDATE(),23)");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        
        public DataTable select_rezerve_tc(int seferno, int koltukno)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC sp_rezerve_tc {0},{1}", seferno, koltukno));
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable adminsilinmissefer_select()
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(" select * from SilinmisSeferler where Tarih>convert(varchar,GETDATE(),23)");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable kayitlar_select(int seferno, int koltukno)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC sp_kayitlar_select {0},{1}", seferno, koltukno));
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        
        public DataTable rezerve_select(int seferno)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC sp_rezerveselect {0}", seferno));
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        
        

        public DataTable admin_koltuk(int seferno)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC sp_admin_koltuk {0}", seferno));
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }

        public DataTable select_seferler(string Tarih, string Kalkis, string Varis)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC sp_seferler_Select '{0}','{1}','{2}'", Tarih, Kalkis,Varis));
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt; 
        }
        public DataTable select_koltuklar(int seferno)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC sp_koltuklar_Select {0}", seferno));
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt; 
        }
        public DataTable select_müsteri_kayitlar(int mstrID)
        {
            SqlDataReader dr = anaekran.Db_Connect.Sql_DataReader(string.Format("EXEC sp_müsteri_kayitlari {0}", mstrID));
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt; 
        }

       
    }
}
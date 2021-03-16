using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumPractice
{
    public enum DocumentType
    {
        [Description("Ameliyat Notu")]
        AmeliyatNotu,

        [Description("Anestezi Notu")]
        AnesteziNotu,

        [Description("Konsültasyon Raporu")]
        KonsultasyonRp,

        [Description("Epikriz Notu")]
        EpikrizNotu,

        [Description("Fatura")]
        Fatura,

        [Description("Görüşme Sonucu?")]
        GorSonuc,

        [Description("Hasta Bilgi Formu")]
        HastaBilgiFormu,

        [Description("Diğer Tazmin Evrak")]
        DigerTazmEvr,

        [Description("İbraname")]
        ibraname,

        [Description("Reçete")]
        Recete,

        [Description("Tetkik Sonucu")]
        TetkikSonucu,

        [Description("Patoloji Sonucu")]
        PatolojiSonuc,

        [Description("Poliklinik Kaydı")]
        PolklinikKaydi,

        [Description("Sigortalı Beyan")]
        SigortaliBeyan,

        [Description("Tedavi Planı")]
        TedaviPlani,

        [Description("Fatura Döküm")]
        FaturaDokum,

        [Description("Açık Rıza Beyanı")]
        AcikRizaBeyani
}

    public enum MimeType
    {
        [Description("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
        sheet,

        [Description("application/vnd.ms-excel")]
        excel,

        [Description("application/pdf")]
        pdf, 

        [Description("image/png")]
        png, 

        [Description("image/jpeg")]
        jpeg, 

        [Description("application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
        doc, 

        [Description("application/msword")]
        msword 
    }

    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        public class Document
        {
            string mimetype;
            string name;
            byte[] bytes;
        }

        public class DocumentCollection
        {
            public List<Document> Documents { get; set; }
        }

        public static string GetDocumentType(Enum en)
        {
            Type type = en.GetType();
            MemberInfo[] memInfo = type.GetMember(en.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }
            return en.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Formun içinde bir resim yüklenir.
            //Yüklenen resmin uzantısına göre ve belge tipine göre işlem farklılık göstersin istediğimiz durumlarda, Enum kullanmak mantıklı.
            string doktip = textBox1.Text;
            DocumentType d_type;
            switch (doktip)
            {
                case "AmeliyatNotu":
                    d_type = DocumentType.AmeliyatNotu;
                    break;
                case "AnesteziNotu":
                    d_type = DocumentType.AnesteziNotu;
                    break;
                case "AcikRizaBeyani":
                    d_type = DocumentType.AcikRizaBeyani;
                    break;
                case "EpikrizNotu":
                    d_type = DocumentType.EpikrizNotu;
                    break;
                case "Fatura":
                    d_type = DocumentType.Fatura;
                    break;
                case "FaturaDokum":
                    d_type = DocumentType.FaturaDokum;
                    break;
                case "GorSonuc":
                    d_type = DocumentType.GorSonuc;
                    break;
                case "HastaBilgiFormu":
                    d_type = DocumentType.HastaBilgiFormu;
                    break;
                case "ibraname":
                    d_type = DocumentType.ibraname;
                    break;
                case "KonsultasyonRp":
                    d_type = DocumentType.KonsultasyonRp;
                    break;
                case "PatolojiSonuc":
                    d_type = DocumentType.PatolojiSonuc;
                    break;
                case "PolklinikKaydi":
                    d_type = DocumentType.PolklinikKaydi;
                    break;
                case "Recete":
                    d_type = DocumentType.Recete;
                    break;
                case "SigortaliBeyan":
                    d_type = DocumentType.SigortaliBeyan;
                    break;
                case "TedaviPlani":
                    d_type = DocumentType.TedaviPlani;
                    break;
                case "TetkikSonucu":
                    d_type = DocumentType.TetkikSonucu;
                    break;

                default:
                    d_type = DocumentType.DigerTazmEvr;
                    break;
            }
            dosyaTipi.Text = GetDocumentType(d_type);

            string dokuzan = textBox2.Text;
            MimeType m_type;
            switch (dokuzan)
            {
                case "doc":
                    m_type = MimeType.doc;
                    break;
                case "excel":
                    m_type = MimeType.excel;
                    break;
                case "msword":
                    m_type = MimeType.msword;
                    break;
                case "pdf":
                    m_type = MimeType.pdf;
                    break;
                case "png":
                    m_type = MimeType.png;
                    break;
                case "sheet":
                    m_type = MimeType.sheet;
                    break;

                default:
                    m_type = MimeType.jpeg;
                    break;
            }
            dosyaUzantisi.Text = GetDocumentType(m_type);
        }
    }
}
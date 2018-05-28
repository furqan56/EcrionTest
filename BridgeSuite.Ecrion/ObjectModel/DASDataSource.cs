
namespace BridgeSuite.Ecrion.ObjectModel
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public partial class DASDataSource : DataSource
    {

        private Diagram diagramField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public Diagram Diagram
        {
            get
            {
                return this.diagramField;
            }
            set
            {
                this.diagramField = value;
                this.RaisePropertyChanged("Diagram");
            }
        }
    }
}
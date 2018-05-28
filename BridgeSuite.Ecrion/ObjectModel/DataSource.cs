using System;
using System.Xml.Serialization;


namespace BridgeSuite.Ecrion.ObjectModel
{
    [XmlInclude(typeof(DASDataSource))]
    [XmlInclude(typeof(XmlDataSource))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.6.1064.2")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.ecrion.com/xfws/2.0", TypeName = "IDataSource")]
    public abstract class DataSource : object, System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Figures;
using System.IO;

namespace EndSemensterProject
{
    public class FigureSerializer
    {
        private readonly XmlSerializer serializer;
        private readonly SaveFileDialog saveFileDialog;
        private readonly OpenFileDialog openFileDialog;

        public FigureSerializer()
        {
            Type[] knownTypes = { typeof(Figures.Rectangle), typeof(Circle), typeof(Triangle), };
            serializer = new XmlSerializer(typeof(List<Figure>), knownTypes);

            saveFileDialog = new SaveFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*",
                DefaultExt = "xml",
                Title = "Save Figures"
            };
            openFileDialog = new OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*",
                Title = "Load Figures",
            };
        }

        public void SaveFigures(List<Figure> figures)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    serializer.Serialize(writer, figures);

                }
            }
        }

        public List<Figure> LoadFigures()
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    List<Figure> current = (List<Figure>)serializer.Deserialize(reader);
                    return current;
                }
            }

            return null;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    public  class FigureConverter: JsonConverter<Figure>
    {
        public override void Write(Utf8JsonWriter writer, Figure value, JsonSerializerOptions options)
        {

            writer.WriteStartObject();

            writer.WriteString("Type", value.GetType().Name);
            writer.WriteNumber("X", value.X);
            writer.WriteNumber("Y", value.Y);

            if (value is Rectangle rect)
            {
                writer.WriteNumber("Height", rect.Height);
                writer.WriteNumber("Width", rect.Width);
                writer.WriteNumber("ID", rect.ID);
                //writer.WriteNumber("NextID", Rectangle.NextID);
            }
            else if(value is Triangle trig)
            {
                writer.WriteNumber("FirstSide", trig.FirstSide);
                writer.WriteNumber("SecondSide",trig.SecondSide);
                writer.WriteNumber("ThirdSide", trig.ThirdSide);
                writer.WriteNumber("ID", trig.ID);
                //writer.WriteNumber("NextID", Triangle.NextID);

            }
            else if(value is Circle circ)
            {
                writer.WriteNumber("Radius", circ.Radius);
                writer.WriteNumber("ID", circ.ID);
                //writer.WriteNumber("NextID", Circle.NextID);
            }
            writer.WriteEndObject();
        }
        public override Figure Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (var doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;
                var type = root.GetProperty("Type").GetString();


                switch (type)
                {
                    case "Rectangle":
                        return JsonSerializer.Deserialize<Rectangle>(root.GetRawText(), options);
                    case "Circle":
                        return JsonSerializer.Deserialize<Circle>(root.GetRawText(), options);
                    case "Triangle":
                        return JsonSerializer.Deserialize<Triangle>(root.GetRawText(), options);
                    default:
                        throw new NotSupportedException($"Unknown type: {type}");
                }
            }
        }
    }
}

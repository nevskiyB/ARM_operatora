using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ARM.InterfaceInteraction
{
    public class Formatter
    {
        string errorMessage = "Данные в файле повреждены или сохранены с некорректным названием!";
        public void WriteBoardList(List<Device> devices, string path)
        {
            BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));

            foreach (Board item in devices)
            {
                writer.Write("B");
                writer.Write(item.Name);
                if (item.Note == null)
                    writer.Write(" ");
                else
                    writer.Write(item.Note);
                writer.Write(item.TimeConst);
                writer.Write(item.TransientProcessTime);
            }

            writer.Close();
        }
        public List<Board> ReadBoardList(string path)
        {
            BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));
            List<Board> boards = new List<Board>();

            try
            {
                while (reader.PeekChar() > -1)
                {
                    if (reader.ReadString() == "B")
                        boards.Add(new Board());
                    boards[boards.Count - 1].Name = reader.ReadString();
                    boards[boards.Count - 1].Note = reader.ReadString();
                    boards[boards.Count - 1].TimeConst = reader.ReadDouble();
                    boards[boards.Count - 1].TransientProcessTime = reader.ReadDouble();
                }
            }
            catch
            {
                MessageBox.Show(errorMessage);
                reader.Close();
                return null;
            }
            reader.Close();

            return boards;
        }

        public void WriteBakeList(List<Device> devices, string path)
        {
            BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));

            foreach (Bake item in devices)
            {
                writer.Write("B");
                writer.Write(item.Name);
                if(item.Note == null)
                    writer.Write(" ");
                else
                    writer.Write(item.Note);
                writer.Write(item.ZoneQuantity.ToString());
                writer.Write(item.MaxSpeed);
                writer.Write(item.MinSpeed);
            }

            writer.Close();
        }
        public List<Bake> ReadBakeList(string path)
        {
            BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));
            List<Bake> bakes = new List<Bake>();

            try
            {
                while (reader.PeekChar() > -1)
                {
                    if (reader.ReadString() == "B")
                        bakes.Add(new Bake());

                    bakes[bakes.Count - 1].Name = reader.ReadString();
                    bakes[bakes.Count - 1].Note = reader.ReadString();
                    bakes[bakes.Count - 1].ZoneQuantity = bakes[bakes.Count - 1].ConvertStringToZone(reader.ReadString());
                    bakes[bakes.Count - 1].MaxSpeed = reader.ReadDouble();
                    bakes[bakes.Count - 1].MinSpeed = reader.ReadDouble();
                }
            }
            catch
            {
                MessageBox.Show(errorMessage);
                reader.Close();
                return null;
            }

            reader.Close();

            return bakes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Blocknot
    {
        public Record[] records = new Record[0];

        public Blocknot()
        {

        }

        public void Add(Record record)
        {
            Record[] temp = new Record[records.Length + 1];

            for (int i = 0; i < records.Length; i++)
            {
                temp[i] = records[i];
            }

            temp[temp.Length - 1] = record;
            records = temp;
        }

        public void Remove(int index)
        {
            Record[] temp = new Record[records.Length - 1];

            for (int i = 0; i < index; i++)
            {
                temp[i] = records[i];
            }

            for (int i = index + 1; i < records.Length; i++)
            {
                temp[i - 1] = records[i];
            }

            records = temp;
        }

        public Record Find(string name)
        {
            foreach (Record record in records)
            {
                if (record.Name.ToLower() == name.ToLower())
                    return record;
            }

            return null;
        }

        public Record this[string name]
        {
            get
            {
                return Find(name);
            }
        }

        public Record this[int index]
        {
            get
            {
                return records[index];
            }
        }
    }
}
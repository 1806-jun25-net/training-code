using System;
using System.Collections.Generic;
using System.IO;

namespace XMLSerialization
{
    internal class XMLSerializer
    {
        private Type type;

        public XMLSerializer(Type type)
        {
            this.type = type;
        }

        internal void Serialize(FileStream fileStream, IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }

        internal object Deserialize(object filestream)
        {
            throw new NotImplementedException();
        }
    }
}
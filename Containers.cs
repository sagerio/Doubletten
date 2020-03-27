using System.Collections.Generic;
using System.Linq;

namespace Doubletten
{
	public class Containers : List<Container>
	{
		public Container findByHash(string hash)
		{
			return (from x in this
							where x.hash.Equals(hash)
							select x).FirstOrDefault();
		}

		public Container findByFilename(string filename)
		{
			return (from x in this
							where x.file1.Equals(filename) || x.file2.Equals(filename)
							select x).FirstOrDefault();
		}

	}

}

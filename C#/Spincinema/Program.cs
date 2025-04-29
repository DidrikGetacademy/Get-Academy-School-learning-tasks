namespace Spincinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const axios = require('axios');

            const options = {
  method: 'GET',
  url: 'https://unogsng.p.rapidapi.com/genres',
  headers:
            {
                'X-RapidAPI-Key': '541146a2d1mshfa8f376ccdddfbep14c003jsn14d9b50f65cf',
    'X-RapidAPI-Host': 'unogsng.p.rapidapi.com'
  }
        };

try {
	const response = await axios.request(options);
        console.log(response.data);
} catch (error) {
	console.error(error);
}
        }
    }
}

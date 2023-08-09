using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPanasonic_
{
    public class LanguageManager
    {
        private static LanguageManager instance;
        private ResourceManager resourceManager;
        private CultureInfo currentCulture;

        // Dil yöneticisine erişim için tekil örnek döndüren özellik
        public static LanguageManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new LanguageManager();
                return instance;
            }
        }

        private LanguageManager()
        {
            // ResourceManager'ı oluşturun ve varsayılan dil olarak Türkçe ayarlayın
            resourceManager = new ResourceManager("ProjectPanasonic_.ResourceFile", typeof(LanguageManager).Assembly);
            currentCulture = new CultureInfo("tr");
        }

        // Dil değiştirme işlemini gerçekleştiren metot
        public void ChangeLanguage(string languageCode)
        {
            currentCulture = new CultureInfo(languageCode);
        }

        // Metinleri almak için ResourceManager'ı kullanın
        public string GetString(string key)
        {
            return resourceManager.GetString(key, currentCulture);
        }

        // Mevcut kültürü döndüren özellik
        public CultureInfo CurrentCulture
        {
            get { return currentCulture; }
        }
    }
}


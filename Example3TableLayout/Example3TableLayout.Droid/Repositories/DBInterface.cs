
// Follows example from:
// https://medium.com/@patibrijesh/how-to-use-sqlite-in-a-xamarin-forms-app-2c6ec5894510

using System;
using Android;
using System.IO;
using SQLite;
using Example3TableLayout.Core.Repositories;

//[assembly: Dependency(typeof(DatabaseService))]
namespace Example3TableLayout.Droid.Repositories
{
    public class DBInterface : IDBInterface
    {
        public DBInterface()
        {
        }

        public SQLiteConnection CreateConnection() {
            var sqliteFilename = "English.db";
            string documentsDirectoryPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsDirectoryPath, sqliteFilename);

            // Copy in the pre-created database to the app.
            if (!File.Exists(path)) {
                using (var binaryReader = new BinaryReader(Android.App.Application.Context.Assets.Open(sqliteFilename))) {
                    using (var binaryWriter = new BinaryWriter(new FileStream(path, FileMode.Create))) {
                        byte[] buffer = new byte[2048];
                        int length = 0;
                        while ((length = binaryReader.Read(buffer, 0,buffer.Length)) > 0) {
                            binaryWriter.Write(buffer, 0, length);
                        }
                    }
                }
            }

            var conn = new SQLiteConnection(path);
            return conn;
        }


        void ReadWriteStream(Stream readStream, Stream writeStream) {
            int Length = 256;
            Byte[] buffer = new byte[Length];
            int bytesRead = readStream.Read(buffer, 0, Length);
            while (bytesRead >= 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
                bytesRead = readStream.Read(buffer, 0, Length);
            }
            readStream.Close();
            writeStream.Close();
        }


    }
}

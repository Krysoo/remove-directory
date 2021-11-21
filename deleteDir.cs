using System;

class deleteDir {

        public bool getRidOfDirectory(string dir) {
            try {
                System.IO.Directory.Delete(dir, true);
                return true;
            }
            catch (Exception) {
                return false;
            }
        }
    }
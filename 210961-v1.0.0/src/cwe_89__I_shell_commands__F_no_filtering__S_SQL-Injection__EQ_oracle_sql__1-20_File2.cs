
                /*
                input : shell commands
no filtering
sink : SQL query
                */
                /*
                Copyright 2016 Bertrand STIVALET

Permission is hereby granted, without written agreement or royalty fee, to
use, copy, modify, and distribute this software and its documentation for
any purpose, provided that the above copyright notice and the following
three paragraphs appear in all copies of this software.

IN NO EVENT SHALL AUTHORS BE LIABLE TO ANY PARTY FOR DIRECT,
INDIRECT, SPECIAL, INCIDENTAL, OR CONSEQUENTIAL DAMAGES ARISING OUT OF THE
USE OF THIS SOFTWARE AND ITS DOCUMENTATION, EVEN IF AUTHORS HAVE
BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

AUTHORS SPECIFICALLY DISCLAIM ANY WARRANTIES INCLUDING, BUT NOT
LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
PARTICULAR PURPOSE, AND NON-INFRINGEMENT.

THE SOFTWARE IS PROVIDED ON AN "AS-IS" BASIS AND AUTHORS HAVE NO
OBLIGATION TO PROVIDE MAINTENANCE, SUPPORT, UPDATES, ENHANCEMENTS, OR
MODIFICATIONS.

                */
                
                namespace default_namespace{
                    class Class_27568{
                        string var_27568;
                        public Class_27568(string tainted_2_27568){
                            var_27568 = tainted_2_27568;
                        }
                        public string get_var_27568(){
                            string tainted_2 = null;
string tainted_3 = null;

                            tainted_2 = var_27568;
                            
                //No filtering (sanitization)
                tainted_3 = tainted_2;
            
                            return tainted_3;
                        }
                        
                    }
                }
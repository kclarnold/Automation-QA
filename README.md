This is the payments, automation folder.<BR>
Only actual code and ReadMe(s) go in this repository 
I need to fix the structure --KLA<br>
  * FrameWork  <br>
    * Selenium<br>
      * \<yet to be defined structure\> <br>
   * Scripts<br>
     * Control<br>
   * WebPages<br>
      * SpecFlow<br>
      * TestApps<br>

SPECFLOW - is the specflow form it runs locally needs to be published to Azure.  The form does basic error checking and some parsing there is plenty of room for improvements.

Control - Not present at current.  Will have the powershell scripts that will copy the .feature files into the correct repo, execute the build so we get .cs files the run the tests to pick up any defined steps.  Any missing steps will result in an email to the automation team.  If a test is defined as @acceptance then it will get pushed to dev once the test is running i.e all missing step defs are filled in.

TestApps - Not present at current. these will be the base examples of things like login or calling to the payments api's/web form. 

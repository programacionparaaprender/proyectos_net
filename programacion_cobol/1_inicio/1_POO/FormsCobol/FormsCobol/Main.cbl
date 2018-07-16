       class-id FormsCobol.Main.
       
       method-id Main static
           attribute System.STAThread.
       local-storage section.
       01 mainForm type FormsCobol.Form1.
       procedure division.
       
           set mainForm to new FormsCobol.Form1()
           invoke type System.Windows.Forms.Application::EnableVisualStyles()
           invoke type System.Windows.Forms.Application::Run(mainForm)
           goback.
       
       end method.
       
       end class.

       class-id FormsCobol.Form1 is partial
                 inherits type System.Windows.Forms.Form.
       
       01 components type System.ComponentModel.IContainer.
      
      *> Required method for Designer support - do not modify
      *> the contents of this method with the code editor.
       method-id InitializeComponent private.
       procedure division.
       invoke self::SuspendLayout
      *> 
      *> Form1
      *> 
       set self::ClientSize to new System.Drawing.Size(384 361)
       set self::Name to "Form1"
       set self::Text to "Form1"
       invoke self::add_Load(new System.EventHandler(self::Form1_Load))
       invoke self::ResumeLayout(False)
       end method.

      *> Clean up any resources being used.      
       method-id Dispose override protected.
       procedure division using by value disposing as condition-value.
           if disposing then
             if components not = null then
               invoke components::Dispose()
             end-if
           end-if
           invoke super::Dispose(by value disposing)
           goback.           
       end method.

       end class.

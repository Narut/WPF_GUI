# WPF GUI
##### WPF GUI
```
Dark Blue Theme WPF Form Template
```

##### Useful function
'''
        private async void asyncInvokeText(dynamic obj,string txt)
        {
            await Dispatcher.BeginInvoke((Action)(() => obj.Text = txt  ));
        } 
'''

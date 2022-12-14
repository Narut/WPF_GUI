# WPF GUI
##### WPF GUI
```
Dark Blue Theme WPF Form Template
```

##### Useful function
#### asyncInvokeText
```
        private async void asyncInvokeText(dynamic obj,string txt)
        {
            await Dispatcher.BeginInvoke((Action)(() => obj.Text = txt  ));
        } 
```

#### Task.Run
```
long runningNo = 0;
bool isRunning = true;
    Task.Run(async () =>
    {
        while (isRunning)
        {
            asyncInvokeText(tbStatus, "Status : " + runningNo.ToString());
            await Task.Delay(1);
            runningNo += 1;
        }
    });
```

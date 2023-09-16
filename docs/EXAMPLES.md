# USAGE EXAMPLES

### Log levels
* `LogLevels.Trace`
* `LogLevels.Information`
* `LogLevels.Warning`
* `LogLevels.Error`
* `LogLevels.Critical`

## You can use it in two ways

#### First way to use:
Use log with [levels](#You-can-log-using-diffent-levels:). To log **information, trace or warning**:

```bash
	logger.LogTrace("YOUR_MESSAGE");	
	logger.LogInfo("YOUR_MESSAGE");
	logger.LogWarn("YOUR_MESSAGE");
```
To log **error or critical** use:

```bash
	logger.LogError("YOUR_MESSAGE", exception);
	logger.LogCrit("YOUR_MESSAGE", exception);
```

#### Second way to use
You can use general command instead of log levels. However, you still must to insdicate **[log level](#Log-levels)** in this command:

```bash
	logger.Log("YOUR_MESSAGE", Log level, exception);
```

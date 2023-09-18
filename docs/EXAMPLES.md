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

**‼️If you want to add log id use this template:**

```bash
	logger.LogTrace("YOUR_MESSAGE", null, logId);
	logger.LogInfo("YOUR_MESSAGE", null, logId);
	logger.LogWarn("YOUR_MESSAGE", null, logId);
```

To log **error or critical** use:

```bash
	logger.LogError("YOUR_MESSAGE", exception, logId);
	logger.LogCrit("YOUR_MESSAGE", exception, logId);
```

#### Second way to use
You can use general command instead of log levels. However, you still must to insdicate **[log level](#Log-levels)** in this command:

```bash
	logger.Log("YOUR_MESSAGE", Log level, exception, logId);
```

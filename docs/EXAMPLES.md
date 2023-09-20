# USAGE EXAMPLES

### Log levels
* `LogLevels.Trace`
* `LogLevels.Information`
* `LogLevels.Warning`
* `LogLevels.Error`
* `LogLevels.Critical`

## You can use it in two ways

#### First way to use:
Use log with [levels](#Log-levels). To log **information, trace or warning**:

```bash
	Logf<YOUR_CLASS>.LogTrace("YOUR_MESSAGE");	
	Logf<YOUR_CLASS>.LogInfo("YOUR_MESSAGE");
	Logf<YOUR_CLASS>.LogWarn("YOUR_MESSAGE");
```

**‼️If you want to add log id use this template:**

```bash
	Logf<YOUR_CLASS>.LogTrace("YOUR_MESSAGE", null, logId);
	Logf<YOUR_CLASS>.LogInfo("YOUR_MESSAGE", null, logId);
	Logf<YOUR_CLASS>.LogWarn("YOUR_MESSAGE", null, logId);
```

To log **error or critical** use:

```bash
	Logf<YOUR_CLASS>.LogError("YOUR_MESSAGE", exception, logId);
	Logf<YOUR_CLASS>.LogCrit("YOUR_MESSAGE", exception, logId);
```

#### Second way to use
You can use general command instead of log levels. However, you still must to insdicate **[log level](#Log-levels)** in this command:

```bash
	Logf<YOUR_CLASS>.Log("YOUR_MESSAGE", Log level, exception, logId);
```

**‼️Remember that log id is not ***NECESSARY*****

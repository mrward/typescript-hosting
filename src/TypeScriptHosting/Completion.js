ls.refresh(true);
var items = ls.getCompletionsAtPosition(host.FileName, host.Position, false);
host.updateCompletionInfoAtCurrentPosition(items);

ls.refresh(true);
var items = ls.getCompletionsAtPosition(host.FileName, host.getPosition(), true);
host.updateCompletionInfoAtCurrentPosition(items);
//host.log(foo);
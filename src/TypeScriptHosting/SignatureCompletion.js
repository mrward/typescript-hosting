ls.refresh(true);
var sig = ls.getSignatureHelpItems(host.FileName, host.getPosition());
host.log(sig);
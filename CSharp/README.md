# CSharp Results

To Execute

```bash
dotnet run deleteme01 us-east-1
```

Where `deleteme01` is the name of a CodeCommit repository and `us-east-1` is the AWS reqion in which the CodeCommit repository is deployed.

Results:

```none
Amazon.CodeCommit.Model.RepositoryTriggersListRequiredException: RepositoryTriggersList cannot be null ---> Amazon.Runtime.Internal.HttpErrorResponseException: Exception of type 'Amazon.Runtime.Internal.HttpErrorResponseException' was thrown.
   at Amazon.Runtime.HttpWebRequestMessage.<GetResponseAsync>d__20.MoveNext() in E:\JenkinsWorkspaces\v3-stage-release\AWSDotNetPublic\sdk\src\Core\Amazon.Runtime\Pipeline\HttpHandler\_mobile\HttpRequestMessageFactory.cs:line 443
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.HttpHandler`1.<InvokeAsync>d__9`1.MoveNext() in E:\JenkinsWorkspaces\v3-stage-release\AWSDotNetPublic\sdk\src\Core\Amazon.Runtime\Pipeline\HttpHandler\HttpHandler.cs:line 175
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.Unmarshaller.<InvokeAsync>d__3`1.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.ErrorHandler.<InvokeAsync>d__5`1.MoveNext()
   --- End of inner exception stack trace ---
   at Amazon.Runtime.Internal.HttpErrorResponseExceptionHandler.HandleException(IExecutionContext executionContext, HttpErrorResponseException exception) in E:\JenkinsWorkspaces\v3-stage-release\AWSDotNetPublic\sdk\src\Core\Amazon.Runtime\Pipeline\ErrorHandler\HttpErrorResponseExceptionHandler.cs:line 60
   at Amazon.Runtime.Internal.ErrorHandler.ProcessException(IExecutionContext executionContext, Exception exception) in E:\JenkinsWorkspaces\v3-stage-release\AWSDotNetPublic\sdk\src\Core\Amazon.Runtime\Pipeline\ErrorHandler\ErrorHandler.cs:line 212
   at Amazon.Runtime.Internal.ErrorHandler.<InvokeAsync>d__5`1.MoveNext() in E:\JenkinsWorkspaces\v3-stage-release\AWSDotNetPublic\sdk\src\Core\Amazon.Runtime\Pipeline\ErrorHandler\ErrorHandler.cs:line 104
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.CallbackHandler.<InvokeAsync>d__9`1.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.CredentialsRetriever.<InvokeAsync>d__7`1.MoveNext() in E:\JenkinsWorkspaces\v3-stage-release\AWSDotNetPublic\sdk\src\Core\Amazon.Runtime\Pipeline\Handlers\CredentialsRetriever.cs:line 98
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.RetryHandler.<InvokeAsync>d__10`1.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at Amazon.Runtime.Internal.RetryHandler.<InvokeAsync>d__10`1.MoveNext() in E:\JenkinsWorkspaces\v3-stage-release\AWSDotNetPublic\sdk\src\Core\Amazon.Runtime\Pipeline\RetryHandler\RetryHandler.cs:line 153
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.CallbackHandler.<InvokeAsync>d__9`1.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.CallbackHandler.<InvokeAsync>d__9`1.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.ErrorCallbackHandler.<InvokeAsync>d__5`1.MoveNext() in E:\JenkinsWorkspaces\v3-stage-release\AWSDotNetPublic\sdk\src\Core\Amazon.Runtime\Pipeline\Handlers\ErrorCallbackHandler.cs:line 58
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.MetricsHandler.<InvokeAsync>d__1`1.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter`1.GetResult()
   at CSharp.Program.Main(String[] args) in C:\Users\MarkLocal\Documents\github\CodeCommitRemoveAllTriggers\CSharp\Program.cs:line 29
```
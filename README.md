# Modulos.Messaging.Abstractions
Designed to be placed into shared (e.q., nuget packages) project/packages containing only defined messages and configuration of them. 

#### Why?
Different solutions/projects may use different versions of Modulos.Messaging. For complicated environments, it may be problematic to keep compatible version. It's nothing funny to be forced to update packages just to call messages from another solution. Modulos.Messaging.Abstractions package is going to be very stable and rarely change, so if message-shared packages/projects depend only on Modulos.Messaging.Abstractions it's going to work - no matter of Modulos.Messaging on both sides.

#### Conclusion
It's strongly recommended to split messages definition into a separate project and depend only on Modulos.Messaging.Abstractions. But if you don't share messages model between solutions you can just use Modulos.Messaging. 
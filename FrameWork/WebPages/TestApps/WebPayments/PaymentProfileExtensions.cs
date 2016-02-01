// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace WebPayments.Client
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class PaymentProfileExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transactionIdentifier'>
            /// </param>
            public static object RetrieveGateWayTokenByTransactionidentifier(this IPaymentProfile operations, string transactionIdentifier)
            {
                return Task.Factory.StartNew(s => ((IPaymentProfile)s).RetrieveGateWayTokenByTransactionidentifierAsync(transactionIdentifier), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transactionIdentifier'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> RetrieveGateWayTokenByTransactionidentifierAsync( this IPaymentProfile operations, string transactionIdentifier, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.RetrieveGateWayTokenByTransactionidentifierWithHttpMessagesAsync(transactionIdentifier, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transactionIdentifier'>
            /// </param>
            public static PCIFormSettings GetPCIFormSettingsByTransactionidentifier(this IPaymentProfile operations, string transactionIdentifier)
            {
                return Task.Factory.StartNew(s => ((IPaymentProfile)s).GetPCIFormSettingsByTransactionidentifierAsync(transactionIdentifier), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transactionIdentifier'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PCIFormSettings> GetPCIFormSettingsByTransactionidentifierAsync( this IPaymentProfile operations, string transactionIdentifier, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetPCIFormSettingsByTransactionidentifierWithHttpMessagesAsync(transactionIdentifier, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static AddPaymentProfileAccountResponse AddPaymentProfileAccountByRequest(this IPaymentProfile operations, AddPaymentProfileAccountRequest request)
            {
                return Task.Factory.StartNew(s => ((IPaymentProfile)s).AddPaymentProfileAccountByRequestAsync(request), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AddPaymentProfileAccountResponse> AddPaymentProfileAccountByRequestAsync( this IPaymentProfile operations, AddPaymentProfileAccountRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.AddPaymentProfileAccountByRequestWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static SaveProfileResponse AddPaymentProfileByRequest(this IPaymentProfile operations, AddPaymentProfileRequest request)
            {
                return Task.Factory.StartNew(s => ((IPaymentProfile)s).AddPaymentProfileByRequestAsync(request), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SaveProfileResponse> AddPaymentProfileByRequestAsync( this IPaymentProfile operations, AddPaymentProfileRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.AddPaymentProfileByRequestWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static SaveProfileResponse UpdatePaymentProfileByRequest(this IPaymentProfile operations, UpdatePaymentProfileRequest request)
            {
                return Task.Factory.StartNew(s => ((IPaymentProfile)s).UpdatePaymentProfileByRequestAsync(request), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SaveProfileResponse> UpdatePaymentProfileByRequestAsync( this IPaymentProfile operations, UpdatePaymentProfileRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.UpdatePaymentProfileByRequestWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static BaseResponse DeletePaymentProfileByRequest(this IPaymentProfile operations, DeletePaymentProfileRequest request)
            {
                return Task.Factory.StartNew(s => ((IPaymentProfile)s).DeletePaymentProfileByRequestAsync(request), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BaseResponse> DeletePaymentProfileByRequestAsync( this IPaymentProfile operations, DeletePaymentProfileRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.DeletePaymentProfileByRequestWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static AddPaymentResponse AddPaymentByRequest(this IPaymentProfile operations, AddPaymentRequest request)
            {
                return Task.Factory.StartNew(s => ((IPaymentProfile)s).AddPaymentByRequestAsync(request), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AddPaymentResponse> AddPaymentByRequestAsync( this IPaymentProfile operations, AddPaymentRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.AddPaymentByRequestWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

    }
}

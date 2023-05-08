using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Contracts;
using WebApi.Contracts.RepositoryWrapper;

namespace WebApi.UnitTests.Mocks
{
    internal class MockIRepositoryWrapper
    {
        public static Mock<IRepositoryWrapper> GetMock()
        {
            var mock = new Mock<IRepositoryWrapper>();
            var studentRepoMock = MockIStudentRepository.GetMock();
            mock.Setup(m => m.Student).Returns(() => studentRepoMock.Object);
            
            mock.Setup(m => m.Save()).Callback(() => { return; });
            return mock;
        }
    }
}

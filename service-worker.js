'use strict';
/*
self.addEventListener('push', function(event) {
  console.log('Received a push message ', event);
  console.log(event.data);

  var title = 'Thông báo';
  var body = 'Bạn đã nhận được một tin nhắn mới';
  var icon = '/images/icon-192x192.png';
  var tag = 'simple-push-demo-notification-tag';

  event.waitUntil(
    self.registration.showNotification(title, {
      body: body,
      icon: icon,
      tag: tag
    })
  );
});
*/
self.addEventListener('push', function(event) {

  var apiPath = 'http://localhost:8055/get-notification.php';
  event.waitUntil(registration.pushManager.getSubscription().then(function (subscription){
      var arrTemp = subscription.endpoint.split("/");
      var subscriptionId = arrTemp[arrTemp.length - 1];

      return fetch(apiPath + "?s=" + subscriptionId).then(function(response){
          console.log("test5");

          if(response.status !== 200){
              throw new Error();
          }

          return response.json().then(function(data){
              var title = data.title;
              var message = data.body;
              var icon = data.icon;
              var tag = data.tag;
              var url = data.url;
              return self.registration.showNotification(title,{
                 body: message,
                 icon: icon,
                 tag: tag,
                 data: url
              });
          })
      }).catch(function(err){

      })

  }));
return;
});

self.addEventListener('notificationclick', function(event) {
  console.log('On notification click: ', event.notification.tag);
  // Android doesn’t close the notification when you click on it
  // See: http://crbug.com/463146
  event.notification.close();

  // This looks to see if the current is already open and
  // focuses if it is
  event.waitUntil(clients.matchAll({
    type: 'window'
  }).then(function(clientList) {
    if (clients.openWindow) {
      return clients.openWindow(event.notification.data);
    }
  }));
});

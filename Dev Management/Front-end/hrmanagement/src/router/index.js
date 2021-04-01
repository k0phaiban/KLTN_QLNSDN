import Vue from 'vue'
import Router from 'vue-router'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      redirect: '/HRManagement'
    },
    {
      path: '/HRManagement',
      name: 'HRManagement',
      component:  () => import('../view/HRManagement'),
      children: [
        {
          path: '',
          redirect: 'Dashboard'
        },
        {
          path: 'Profile',
          name: 'Profile',
          component:  () => import('../view/HRManagement/Profile'),
        },
        {
          path: 'Dashboard',
          name: 'Dashboard',
          component:  () => import('../view/HRManagement/Dashboard'),
        },
        {
          path: 'Timekeeping',
          name: 'Timekeeping',
          component:  () => import('../view/HRManagement/Timekeeping'),
        },
        {
          path: 'Appoint',
          name: 'Appoint',
          component:  () => import('../view/HRManagement/Appoint'),
        },
        {
          path: 'Contract',
          name: 'Contract',
          component:  () => import('../view/HRManagement/Contract'),
        },
        {
          path: 'Dismissed',
          name: 'Dismissed',
          component:  () => import('../view/HRManagement/Dismissed'),
        },
        {
          path: 'Dispatch',
          name: 'Dispatch',
          component:  () => import('../view/HRManagement/Dispatch'),
        },
        {
          path: 'Report',
          name: 'Report',
          component:  () => import('../view/HRManagement/Report'),
        },
        {
          path: 'OrganizationUnit',
          name: 'OrganizationUnit',
          component:  () => import('../view/HRManagement/Setting/OrganizationUnit'),
        }
      ]
    },
    {
      path: '/login',
      name: 'Login',
      component:  () => import('../login')
    }
  ]
})
